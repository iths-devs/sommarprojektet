import React, { FC } from 'react';

import logo from './logo.svg';
import SimpleGet from './Components/SimpleGetRequestTemplate';

import { BrowserRouter as Router, Routes, Route, Link } from 'react-router-dom';

import './App.css';
import Home from '../src/components/Home';
import MyCourses from '../src/components/MyCourses';
import logoImage from '../src/images/logoITHS.png';

const App: FC = () => {
    return (
        <div className='App'>
            <SimpleGet />

            <Router>
                <header>
                    <nav className='nav'>
                        <Link to='/'>
                            {' '}
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
