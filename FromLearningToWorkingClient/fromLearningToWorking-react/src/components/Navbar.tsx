import React from 'react';
import { Link } from 'react-router-dom';
// import './Navbar.css'; // Assuming you have some basic styles
// import { Link } from 'react-router-dom';

const Navbar: React.FC = () => {
    return (
        <nav className="navbar">
            <div className="navbar-logo">
                <Link to="/">home</Link>
            </div>
            <ul className="navbar-links">
                <li>
                    <Link to="/login">Login</Link>
                </li>
                <li>
                    <Link to="/register">Register</Link>
                </li>
            </ul>
        </nav>
    );
};

export default Navbar;