import { NavLink } from "react-router-dom"


type Props = {}

const Navbar = (props: Props) => {
  return (
    <nav className="d-flex gap-3 p-3 border-bottom mb-3">
        <NavLink to="/">Home</NavLink> 
        <NavLink to="/about">About</NavLink>  
        <NavLink to="/first">Ćwiczenie 1</NavLink>  
    </nav>
  )
}

export default Navbar