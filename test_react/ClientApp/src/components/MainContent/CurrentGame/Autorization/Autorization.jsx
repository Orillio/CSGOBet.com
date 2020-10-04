import React from 'react';
import classes from './Autorization.module.css';
import autoriz from './images/sign.png';

const Autorization = () => {
    return (
        <a href="/login" className={classes.link}>
            <img type="submit" src={autoriz} alt="autorization" className={classes.btn}/>
        </a>
    );
}

export default Autorization;