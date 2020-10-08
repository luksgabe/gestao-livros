import axios from 'axios';

const api = axios.create({
    baseURL: process.env.REACT_APP_API_URL,
});

console.log(`address api: ${process.env.REACT_APP_API_URL} ` );
  
export default api;