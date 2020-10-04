import React from 'react';
import Autorization from './Autorization/Autorization';
import classes from './CurrentGame.module.css';
import $ from "jquery";

const CurrentGame = (props) => {
    return (
        <div className={classes.currentGameWrapper}>
            <span className={classes.total}>Игра#{props.total}</span>
            <Autorization /> 
        </div>
    );
}

export default CurrentGame;