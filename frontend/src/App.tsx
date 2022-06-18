import React from 'react';
import SimpleGet from './components/SimpleGetRequestTemplate';
import { BrowserRouter as Router, Routes, Route, Link } from 'react-router-dom';

import { useIsAuthenticated } from '@azure/msal-react';
import './App.css';
import Home from './components/Home';
import MyCourses from './components/MyCourses';
import { SignOutButton } from './components/SignOutButton';
import { SignInButton } from './components/SignInButton';
import logoImage from '../src/images/logoITHS.png';

const App = () => {
    const isAuthenticated = useIsAuthenticated();

    return (
        <div className='App'>
            {/* <SimpleGet /> */}
            {!isAuthenticated ? (
                <div>
                    <header>
                        <nav>
                            <img src={logoImage} alt='logo' />
                        </nav>
                    </header>
                    <SignInButton />
                </div>
            ) : (
                <Router>
                    <header>
                        <nav className='nav'>
                            <Link to='/'>
                                <img src={logoImage} alt='logo' />
                            </Link>
                            <Link to='/'> Hem </Link>
                            <Link to='/courses'> Mina kurser </Link>
                            <SignOutButton />
                        </nav>
                    </header>
                    <main>
                        <Routes>
                            <Route path='/courses' element={<MyCourses />} />
                            <Route path='/' element={<Home />} />
                        </Routes>
                    </main>
                </Router>
            )}
        </div>
    );
};

export default App;
