function Counter(){
    let count = 0;
    let p = 0;
    let q =0;
    const increment = () => {
        count++;
        document.getElementById('c1').innerText = count;
    }
    const decrement = () => {
        count--;
        document.getElementById('c1').innerText = count;
    }
    const reset =()=>{count=0;document.getElementById('c1').innerText=count;}
    const call = () => {        
        p = document.getElementById("userInp1").value;
        q = document.getElementById("userInp2").value;
        const sum = parseInt(p)+parseInt(q);
        document.getElementById('c2').innerText = sum;

        {/* const q = prompt("Enter the second number");
        var sum = p+q;
        document.getElementById('c2').innerText = sum; */}
        
        }
    // let a = 10;
    // console.log(x)
    // var x = 5;
    // if(true){
    // //     var a =1;
    // //     let b = 2;
    // //     const c = 3;
    //     console.log(a);
    // }

    //usestate with array destructuring
    // let x =1, b = 2;
    // [x,b] = [b,x]
    
    // console.log(x);
    // console.log(b);

    //Spread operator

    // const prev = {name: 'A', age : 20};
    // const next = {...prev, age:21, city:'Agra'}      

    // console.log(next)
    // destructuring objects in js

    // const user = {
    //     name:"Soumya",
    //     age:23,
    //     info:{
    //         city:"Kolkata",
    //         state:"West Bengal"
    //     }
    // }

    // console.log(user)

    // const {name: userName = 'Aaron', info: {city} = {}} = user2;
    // console.log(user2)

    // console.log(a);
    // var x = 10;
    // console.log(x);
    // var x = 11;

    return(
        <div>
        <h1 id = "c1">0</h1>
        <button onClick = {increment}>INC</button>
        <button onClick = {decrement}>DEC</button>
        <button onClick = {reset}>RST</button>

        
        <h1 id = "c2">0</h1> 
        <input type='text' id = 'userInp1' placeholder="First Number"/>
        <input type='text' id = 'userInp2' placeholder="Second Number"/>
        <button onClick = {call}>ADD</button>
        
        </div>
    )
}

export default Counter;