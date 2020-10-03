import React from 'react';
import classes from './LogoSide.module.css';

const LogoSide = (props) => {
    return (
        <div className={classes.wrapperLogoSide}>
            <div className={classes.logoSide}>
                <span className={classes.logo}>LOGO</span>
                <span className={classes.online}>
                <span>Онлайн: {props.liveOnline}</span>
                    <div className={classes.greenRound}></div>
                </span>
            </div>
            {/* <div className={classes.signIn}>
                
            </div> */}
        </div>
    );
}

export default LogoSide;