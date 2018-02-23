function search() {
    let searchText = $('#searchText').val();
    let result = $('#result');
    let count = 0;

    $('#towns li').each(function (index, text) {
        if (text.textContent.includes(searchText)){
            $(text).css("font-weight", "bold");
            count++;
        }
    });

    result.text(count + ' matches found.')
}