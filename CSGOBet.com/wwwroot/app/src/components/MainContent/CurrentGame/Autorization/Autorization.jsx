import React from 'react';
import classes from './Autorization.module.css';
import autoriz from './images/sign.png';

const Autorization = () => {
    return (
        <img src={autoriz} alt="autorization" className={classes.btn}/>
    );
}

export default Autorization;