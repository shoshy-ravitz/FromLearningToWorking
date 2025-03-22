import  {createBrowserRouter } from 'react-router';
import Home from './components/Home';
import React from 'react';
import Login from './components/Login';
import Register from './components/Register';
import Navbar from './components/Navbar';


export const router = createBrowserRouter([
    {path: '/', element: <Navbar />},
    {path: '/home', element: <Home />},
    {path: '/login', element: <Login />},
    {path: '/register', element: <Register />},
  
]);


