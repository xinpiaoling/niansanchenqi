function blockScope() {
    if (true) {
        var i = 555;

    }
    console.log('i=' + i);
}
blockScope();