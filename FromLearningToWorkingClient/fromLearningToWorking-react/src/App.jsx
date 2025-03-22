import './App.css'
// import { RouterProvider } from 'react-router-dom'
import Navbar from './components/Navbar'
import { router } from './Router'
import Home from './components/Home'
import { RouterProvider } from 'react-router'
import Login from './components/Login'
import Register from './components/Register'
import ResumeUploader from './components/ResumeUploader'
function App() {

  return (
    <>
    <Login />
    <Register />
    <ResumeUploader/>
{/* <RouterProvider router={router} /> */}
   

    {/* <RouterProvider router={router} /> */}
   
    </>
  )
}

export default App
