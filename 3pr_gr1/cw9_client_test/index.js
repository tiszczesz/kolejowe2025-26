async function GetStudents() {
    const response = await fetch('http://localhost:5113/api/students');
    const data = await response.json();
    console.log(data);
}

GetStudents();