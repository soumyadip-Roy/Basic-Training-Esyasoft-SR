import { useState } from "react";

function EventComponent(){
    const [num,setNum] = useState(10);

    const onChangeHandlernum = () => {
        console.log("event_change_num");
    }

    // const onChangeHandlertext = (e) => {
    //     console.log(dummyJson.target.value);
    // }
    const onChangeHandlertext = (e) => {
        // console.log(e.target.value);
        
        if((e.target.value === dummyJson.target.value)){
            console.log("Yes Name matches")
        }

    }

    const dummyJson = {
        "firstName":"First Name",
        "lastName":"Last Name",
        "target":{
            "value":"Soumyadip"
        }
    }

    // increaseNum =() =>{}
    return (
        <> {/* Creating react fragments with the <></> code, we can also use <React.Fragment></React.Fragment> */}
            Welcome to Events!
            <button onClick={()=>{
                console.log("Button Clicked")
            }}>Click for Log</button>
            <div style={{background: 'blue', padding: 20}} onMouseEnter={() =>{
                console.log("Mouse entered the 1st Div")
            }}>
                Enter the Div for mouse movement log
            </div>
            <div style={{background: 'blue', padding: 20}} onMouseLeave={() =>{
                console.log("Mouse left the 2nd Div")
            }}>
                Enter the Div for mouse movement log
            </div>
            <div style={{background: 'blue', padding: 20}} onMouseEnter={() =>{
                console.log("Mouse entered the 3rd Div")
            }} onMouseLeave={
                console.log("The mouse has left after entering the 3rd Div")
            }>
                Enter the Div for mouse movement log
            </div>
            <div>
                <input type="number" min={1} max={10} onChange={onChangeHandlernum}></input>
                <input type="text" onChange={onChangeHandlertext}></input>
            </div>
        </>
);
}

export default EventComponent;