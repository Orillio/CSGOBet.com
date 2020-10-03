import React from 'react';
import classes from './MainContent.module.css';
import CurrentGame from './CurrentGame/CurrentGame';

const MainContent = () => {
    return (
        <div className={classes.mainContentWrapper}>
            <CurrentGame />
        </div>
    );
}

export default MainContent;