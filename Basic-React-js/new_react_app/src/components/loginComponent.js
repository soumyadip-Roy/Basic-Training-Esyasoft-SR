import { useState } from "react";

function LoginComponent(){

    const [userName, setUserName] = useState('default');
    const [passWord, setPassWord] = useState('default');

    const loginButtonHandler = (e) => {
        if(userName!=="username"){
            alert("Invalid Username")
            return;
        }
        if(passWord!=="password"){
            alert("Invalid Password")
            return;
        }
        alert("Login Succesful!")
    }
    const updateUsername =(e) => {
        setUserName(e.target.value)
    }
    const updatePassword = (e) => {
        setPassWord(e.target.value)
    }
    
    return(
        <>
        <h1>Login Form</h1>
        <div>
            <input type="text" placeholder="Enter Name" onChange={updateUsername}/>
            <input type="password" placeholder="Enter your password" onChange={updatePassword}/>
            <button onClick={loginButtonHandler}>Login</button>
        </div>
        
        </>
    )
}
export default LoginComponent;