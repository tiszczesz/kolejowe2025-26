import 'bootstrap/dist/css/bootstrap.min.css'
import { Route, Routes } from 'react-router-dom'
import './App.css'
import Navbar from './layout/Navbar'
import Home from './pages/Home'
import About from './pages/About'
import NotFound from './pages/NotFound'
import FirstExercise from './pages/FirstExercise'

function App() {
  

  return (
    <>
     <header>
      <Navbar />
     </header>
     <main>
      <Routes>
        
          <Route index element={<Home/>} />
          <Route path="about" element={<About/>} />
          <Route path="*" element={<NotFound />} />
          <Route path="first" element={<FirstExercise />} />
        
      </Routes>
     </main>
     
     <footer className="text-center p-3 border-top mt-3">
      footer &copy; 2024
     </footer>
    </>
  )
}

export default App
