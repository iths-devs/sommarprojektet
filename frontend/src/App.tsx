import React from 'react';
import SimpleGet from './components/SimpleGetRequestTemplate';
import { BrowserRouter as Router, Routes, Route, Link } from 'react-router-dom';

import './App.css';
import Home from './components/Home';
import MyCourses from './components/MyCourses';
import logoImage from '../src/images/logoITHS.png';

const App = () => {
    return (
        <div className='App'>
            <SimpleGet />

            <Router>
                <header>
                    <nav className='nav'>
                        <Link to='/'>
                            <img src={logoImage} alt='logo' />
                        </Link>
                        <Link to='/'> Hem </Link>
                        <Link to='/courses'> Mina kurser </Link>
                    </nav>
                </header>
                <main>
                    <Routes>
                        <Route path='/courses' element={<MyCourses />} />
                        <Route path='/' element={<Home />} />
                    </Routes>
                </main>
            </Router>
        </div>
    );
};

export default App;
