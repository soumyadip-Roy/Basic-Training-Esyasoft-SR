import { useState } from "react";

function LoginFormComponent(){

    const [userName, setUserName] = useState('');
    const [passWord, setPassWord] = useState('');

    const loginFormHandler = (e) => {
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
        <form onSubmit={loginFormHandler}>
            <input type="text" value={userName} placeholder="Enter Name" onChange={(e)=>{setUserName(userName)}}/>
            <input type="password" value={passWord} placeholder="Enter your password" onChange={(e) => {setPassWord(passWord)}}/>
            <button type='submit'>Login</button>
            <button type='reset'>Reset</button>
        </form>
        
        </>
    )
}
export default LoginFormComponent;