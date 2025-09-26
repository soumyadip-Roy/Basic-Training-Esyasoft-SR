import React from "react";
import { useContext } from "react";
import { ContextGlobal } from "../App";


export default function UseContextComponent(){

    const {theme,count,setTheme} = useContext(ContextGlobal)
    const handleThemeChange = () => {
        if(theme === '#ffffffff'){
            setTheme('#ef0606ff')
        }
        else{setTheme('#ffffffff')}
    }

    return(
        <div>
            This is the use context hook return
            <div>{theme}</div>
            <button onClick={handleThemeChange}>Change Theme:{theme}</button>
        </div>
    )
};