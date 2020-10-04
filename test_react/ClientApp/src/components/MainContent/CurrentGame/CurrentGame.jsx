import React from 'react';
import Autorization from './Autorization/Autorization';
import classes from './CurrentGame.module.css';
import $ from "jquery";
import LogoSide from '../../Header/LogoSide/LogoSide';

const CurrentGame = (props) => {
    var result = $.get({
        url: "/getAuthKey",
        success: e => console.log(e)
    });
    
    return (
        <div className={classes.currentGameWrapper}>
            <span className={classes.total}>Игра#{props.total}</span>
            <Autorization /> 
        </div>
    );
}

export default CurrentGame;