document.querySelector('select')
      .addEventListener('change', function(e) {
    document.body.style.backgroundColor = e.target.value;
});
