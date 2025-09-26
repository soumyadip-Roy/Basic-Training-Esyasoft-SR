import { useContext } from "react"
import { ContextHighlight } from "./BoxesDisplayComponent"

export default function ButtonPress() {
    const { currClassName, setCurrClassName, count, setCount } = useContext(ContextHighlight)

    const BoxHighlighterComponent = () => {
        setCount((count + 1))
        console.log(count)
        switch (count) {
            case 0:
                setCurrClassName({ box1: "highlight_box", box2: "box", box3: "box" })
                break;
            case 1:
                setCurrClassName({ box1: "box", box2: "highlight_box", box3: "box" })
                break;
            case 2:
                setCurrClassName({ box1: "box", box2: "box", box3: "highlight_box" })
                setCount(0)
                break;
            default:
                setCount(0)
                break;
        }

    }

    return (
        <div>
            <div style={{ textAlign: 'center' }}>
                <button onClick={BoxHighlighterComponent}>Click to Highlight</button>
            </div>
        </div>
    )
}