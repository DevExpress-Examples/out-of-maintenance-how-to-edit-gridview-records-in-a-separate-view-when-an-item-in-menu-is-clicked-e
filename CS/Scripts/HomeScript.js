function OnItemClick(s, e) {
    if (e.item.name == "edt") {
        window.location = settings.editUrl.replace("-1", grid.GetSelectedKeysOnPage()[0]);
    }
}