import React from 'react';
import LogoSide from './LogoSide/LogoSide';
import NavSide from './NavSide/NavSide';

const Header = () => {
    return (
       <div className="wrapperHeader">
            <LogoSide />
            <NavSide />
       </div>
    );
}

export default Header;