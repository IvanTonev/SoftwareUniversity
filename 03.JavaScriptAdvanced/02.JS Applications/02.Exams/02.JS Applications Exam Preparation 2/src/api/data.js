import * as api from './api.js';

const host = 'http://localhost:3030'
api.settings.host = host;


export const login = api.login;
export const register = api.register;
export const logout = api.logout;

// Application-specific requests

// get all listings
export async function getAllListings(){
    return await api.get(host + '/data/cars?sortBy=_createdOn%20desc');  
}

// create car listing
export async function createCarListing(listing){
    return await api.post(host + '/data/cars/', listing);
}

// get car details
export async function getCarDetails(id){
    return await api.get(host + '/data/cars/' + id);  
}

// edit car listing
export async function editCarListing(id, listing){
    return await api.put(host + '/data/cars/' + id, listing);
    // {
    //     brand,
    //     model,
    //     description,
    //     year,
    //     imageUrl,
    //     price   
    // }
    
}

// delete car Listing
export async function deleteCarListing(id){
    return await api.del(host + '/data/cars/' + id);  
}

//get my car listings
export async function getMyListings(userId){
    return await api.get(host + `/data/cars?where=_ownerId%3D%22${userId}%22&sortBy=_createdOn%20desc`);  
}
