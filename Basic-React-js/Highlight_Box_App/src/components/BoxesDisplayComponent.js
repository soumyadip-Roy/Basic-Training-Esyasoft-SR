import { createContext, useState } from "react";
import BoxHighlighterComponent from "./BoxHighlighter";
import ButtonPress from "./BoxHighlighter";

const ContextHighlight = createContext(null);

export default function BoxesDisplayComponent() {
    const [currClassName, setCurrClassName] = useState({
        box1: "box",
        box2: "box",
        box3: "box"
    })
    const [count, setCount] = useState(0)

    return (

        <ContextHighlight.Provider value={{
            currClassName: currClassName,
            setCurrClassName: setCurrClassName,
            count: count,
            setCount: setCount
        }}>
            <div >
                <div className="parent">
                    <div itemID='box1' className={currClassName.box1} style={{ background: '#c82020ff' }}>Box 1</div>
                    <div itemID='box2' className={currClassName.box2} style={{ background: '#20c85bff' }}>Box 2</div>
                    <div itemID='box3' className={currClassName.box3} style={{ background: '#5220c8ff' }}>Box 3</div>

                </div>
                <ButtonPress />
            </div>
        </ContextHighlight.Provider>


    );
}
export { ContextHighlight };