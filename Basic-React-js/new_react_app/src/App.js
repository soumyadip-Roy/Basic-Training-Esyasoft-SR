import { useState } from "react";
import LoginComponent from "./components/loginComponent";
import LoginFormComponent from "./components/loginFormComponent";

function App({name, tagline}) {
  const [counter,setCounter] = useState(0)
  var incrementButtonHandler = () => {
  console.log("Increment Button Handler");
  setCounter(counter+1);
}
const decrementButtonHandler = () => {
  setCounter(counter-1);
  console.log("Decrement Button Handler")
};
  return (
    <div className="App">

      {/* <div>{counter}</div> */}
      {/* <h1>Name: {name} </h1>
      // <h1>Tagline: {tagline}</h1> */}
      {/* <button onClick={incrementButtonHandler}>increment</button>
      <button onClick={decrementButtonHandler}>decrement</button> */}

        <LoginFormComponent />


    </div> // this is in jsx not html. what makes them different?
  );
}

export default App;


/*jsx ys html, what is the difference if they both look the same?
The existing javascript also had a conflict wiuth the html keywords, so
they went ahead and created a new language called jsx which can be used in 
conjunction with html which doesnt have any conflicts.
*/