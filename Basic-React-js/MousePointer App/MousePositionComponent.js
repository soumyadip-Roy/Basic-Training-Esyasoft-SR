import React, { useState, useEffect } from "react";

const MousePositionFunction=()=>{
    const [mousePosition,setMousePosition] = useState({x_pos:null, y_pos:null});
    useEffect(()=>{
        const updateMousePosition = (event) =>{
            setMousePosition({x_pos:event.clientX,y_pos:event.clientY})
        };
        window.addEventListener('mousemove',updateMousePosition);

        return ()=>{
            window.removeEventListener('mousemove',updateMousePosition);
        };
        
    },[]);

    return (
        <div>
            <div>

                <h1>Mouse Position:</h1>
               <h2> X_pos:{mousePosition.x_pos}, Y_pos={mousePosition.y_pos}</h2>
            </div>
        </div>
    );
};

export default function mousePosition(){
    return(MousePositionFunction())
}
