import {showHome} from './home.js';

async function getLikesByMovieId(id) {
    const response = await fetch(`http://localhost:3030/data/likes?where=movieId%3D%22${id}%22&distinct=_ownerId&count`);
    const data = await response.json();

    return data;
}

async function getOwnLikesByMovieId(id) {
    const userId = sessionStorage.getItem('userId');
    const response = await fetch(`http://localhost:3030/data/likes?where=movieId%3D%22${id}%22%20and%20_ownerId%3D%22${userId}%22 `);
    const data = await response.json();

    return data;
}


async function getMovieById(id) {
    const response = await fetch('http://localhost:3030/data/movies/' + id);
    const data = await response.json();

    return data;
}

async function onDelete(event, id) {
    event.preventDefault();
    const confirmed = confirm('Are you sure you want to delete this movie?');

    if (confirmed) {
        const response = await fetch('http://localhost:3030/data/movies/' + id, {
            method: 'delete',
            headers: {
                'X-Authorization': sessionStorage.getItem('authToken')
            }
        });
        if (response.ok) {
            alert('Movie deleted');
            showHome();
        } else {
            const error = await response.json();
            alert(error.message);
        }
    }



}

function createMovieCard(movie, likes, ownLike) {
    const controls = document.createElement('div');
    controls.className = 'col-md-4 text-center';
    controls.innerHTML = ` <h3 class="my-3 ">Movie Description</h3>
    <p>${movie.description}</p>`;

    const userId = sessionStorage.getItem('userId');
    if (userId != null) {
        if (userId == movie._ownerId) {
            const deleteA = document.createElement('a');
            deleteA.className = 'btn btn-danger';
            deleteA.setAttribute('href', '#');
            deleteA.textContent = 'Delete';
            deleteA.addEventListener('click', (event) => onDelete(event, movie._id));
            controls.appendChild(deleteA);

            const editA = document.createElement('a');
            editA.className = 'btn btn-warning';
            editA.setAttribute('href', '#');
            editA.textContent = 'Edit';
            controls.appendChild(editA);

        } else if (ownLike.length == 0) {
            const likeA = document.createElement('a');
            likeA.className = 'btn btn-primary';
            likeA.setAttribute('href', '#');
            likeA.textContent = 'Like';
            likeA.addEventListener('click', likeMovie);
            controls.appendChild(likeA);
        }
    }

    const likesSpan = document.createElement('span');
    likesSpan.className = 'enrolled-span';
    likesSpan.textContent = likes + ' like' + (likes == 1 ? '' : 's');
    controls.appendChild(likesSpan);

    const element = document.createElement('div');
    element.className = 'container';
    element.innerHTML = ` 
    <div class="row bg-light text-dark">
        <h1>Movie title: ${movie.title}</h1>   
    </div>`

    const img = document.createElement('div');
    img.className = 'col-md-8';
    img.innerHTML = `  <img class="img-thumbnail"
    src="${movie.img}" alt="Movie">`;

    element.appendChild(img);
    element.appendChild(controls);

    return element;

    async function likeMovie(event) {
        const response = await fetch('http://localhost:3030/data/likes', {
            method: 'post',
            headers: {
                'Content-Type': 'application/json',
                'X-Authorization': sessionStorage.getItem('authToken')
            },
            body: JSON.stringify({ movieId: movie._id })
        });
        if (response.ok) {
            event.target.remove();
            likes++;
            likesSpan.textContent = likes + ' like' + (likes == 1 ? '' : 's');
        }

    }
}

let main;
let section;


export function setupDetails(mainTarget, sectionTarget) {
    main = mainTarget;
    section = sectionTarget;
}

export async function showDetails(id) {
    section.innerHTML = '';
    main.innerHTML = '';
    main.appendChild(section);

    const [movie, likes, ownLike] = await Promise.all([
        getMovieById(id),
        getLikesByMovieId(id),
        getOwnLikesByMovieId(id)
    ]);
    const card = createMovieCard(movie, likes, ownLike);
    section.appendChild(card);

}
