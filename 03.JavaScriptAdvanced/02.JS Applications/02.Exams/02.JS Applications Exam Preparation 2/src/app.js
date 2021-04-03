import {render} from '../node_modules/lit-html/lit-html.js';
import page from '../node_modules/page/page.mjs';


import {logout as apiLogout} from './api/data.js';
import {getUserData} from './utility.js';
import { homePage } from './views/home.js';
import { loginPage, registerPage } from './views/auth.js';
import { catalogPage } from './views/catalog.js';
import { detailsPage } from './views/details.js';
import { createPage } from './views/create.js';


const main = document.getElementById('site-content');
document.getElementById('logoutBtn').addEventListener('click', logout);

setUserNav();

page('/', decorateContext, homePage);
page('/login', decorateContext, loginPage);
page('/register', decorateContext, registerPage);
page('/all-listings', decorateContext, catalogPage);
page('/details/:id', decorateContext, detailsPage);
page('/create', decorateContext, createPage);

page.start();

function decorateContext(ctx, next) {
    
    ctx.render = (content) => render(content, main);
    ctx.setUserNav = setUserNav;
    ctx.user = getUserData();

    next();
}

function setUserNav() {
    const user = getUserData();
    if (user) {
        document.getElementById('profile').style.display = 'block';
        document.getElementById('guest').style.display = 'none';
        document.getElementById('user-greeting').textContent = `Welcome ${user.username}`;
    }  else {
        document.getElementById('profile').style.display = 'none';
        document.getElementById('guest').style.display = 'block';
    }
}

function logout(){
    apiLogout(); 
    setUserNav();
    page.redirect('/');
}

/*
create universal request module (api.js)
create application-specific requests (data.js)
setup routing (page)
create context decorator middleware (utility functions)
implement views
*/
