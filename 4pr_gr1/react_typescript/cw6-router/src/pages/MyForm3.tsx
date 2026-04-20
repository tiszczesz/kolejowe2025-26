import React, { useState } from 'react'
type FormResult = {
    name: string;
    option: string;
    age: number;
}


const MyForm3 = () => {
    const [formResult, setFormResult] = useState<FormResult | null>(null);
    console.log('render');
    function actionHandle(formData: FormData): void | Promise<void> {
        console.log('działa action', formData);
        const name = formData.get('name') as string;
        const option = formData.get('option') as string;
        const age = Number(formData.get('age'));
        console.log(name, option, age);
        setFormResult({ name, option, age });
    }

    return (
        <>
            <h3>Formularz 3 z wykorzystaniem action React v19 </h3>
            <form action={actionHandle} >
                <input className='form-control' type="text" placeholder='podaj imię' name='name' /> <br />
                <input className='form-control' type="number" placeholder='podaj wiek' name='age' min={0} max={150} /> <br />
                <select className='form-control' name='option'>
                    <option value="option1">Opcja 1</option>
                    <option value="option2">Opcja 2</option>
                    <option value="option3">Opcja 3</option>
                </select> <br />
                <input className='btn btn-primary' type="submit" value="Wyślij" />
            </form>
            <h3>Wynik:</h3>
            {formResult && (
                <pre>{JSON.stringify(formResult, null, 2)}</pre>
            )}
        </>
    )
}

export default MyForm3