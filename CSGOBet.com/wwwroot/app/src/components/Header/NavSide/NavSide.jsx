import React from 'react';
import classes from './NavSide.module.css';

const NavSide = (props) => {
    return (
        <div className={classes.wrap}>
            <span className={classes.total}>Игр за сегодня :{props.totalGames}</span>
            <div className={classes.navSideWrap}>
                <a href="#" className={classes.about}>О сайте</a>
                <a href="#" className={classes.history}>История игр</a>
            </div>
        </div>
    );
}

export default NavSide;