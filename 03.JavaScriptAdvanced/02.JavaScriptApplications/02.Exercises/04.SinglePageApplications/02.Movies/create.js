import {showDetails} from './details.js'

async function onSubmit(event) {
    event.preventDefault();
    const formData = new FormData(event.target);
    const movie = {
        title: formData.get('title'),
        description: formData.get('description'),
        img: formData.get('imageUrl')
    };
    if (movie.title == '' || movie.description == '' || movie.img == '') {
        return alert('All fields are required');
    }

    const respone = await fetch('http://localhost:3030/data/movies', {
        method: 'post',
        headers: {
            'Content-Type': 'application/json',
            'X-Authorization': sessionStorage.getItem('authToken')
        },
        body : JSON.stringify(movie)
    });

    if (respone.ok) {
        const moive = await respone.json();
        showDetails(movie._id);

    } else {
        const error = await response.json();
        alert(error.message);
    }
}

let main;
let section;


export function setupCreate(mainTarget, sectionTarget) {
    main = mainTarget;
    section = sectionTarget;

    const form = section.querySelector('form');
    form.addEventListener('submit', onSubmit);

}

export async function showCreate() {
    main.innerHTML = '';
    main.appendChild(section);
}
