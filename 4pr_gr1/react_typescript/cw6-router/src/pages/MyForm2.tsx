import React, { useRef, useState, type SubmitEvent } from 'react'

type FormResult = {
    name: string;
    option: string;
}

const MyForm2 = () => {
    console.log('render');
    //zmienne do referencji kontrlek formularza
    const nameRef = useRef<HTMLInputElement>(null);
    const optionRef = useRef<HTMLSelectElement>(null);
    const [formResult, setFormResult] = useState<FormResult | null>(null);
    function handleOnSubmit(e: SubmitEvent<HTMLFormElement>): void {
        e.preventDefault();
        if (nameRef.current && optionRef.current) {
            const name = nameRef.current.value;
            const option = optionRef.current.value;
            console.log(name, option);
            setFormResult({ name, option });
        }
    }

    return (
        <>
            <h3>Formularz 2 z wykorzystaniem useRef </h3>
            <form onSubmit={(e) => handleOnSubmit(e)}>
                <input ref={nameRef} type="text" placeholder='podaj imię' /> <br />
                <select ref={optionRef}>
                    <option value="option1">Opcja 1</option>
                    <option value="option2">Opcja 2</option>
                    <option value="option3">Opcja 3</option>
                </select> <br />
                <input type="submit" value="Wyślij" />
            </form>
            <h3>Wynik:</h3>
            {formResult && (
                <pre>{JSON.stringify(formResult, null, 2)}</pre>
            )}
        </>
    )
}

export default MyForm2