export function hideModal() {
    var modal = new bootstrap.Modal(document.getElementById('createCollectionModal'));
    modal.hide();

    var modalElement = document.getElementById('createCollectionModal');
    modalElement.className = "modal fade";
    modalElement.style = "";
    var backDrop = document.getElementsByClassName('modal-backdrop fade show');
    backDrop[0].className = "";

    modal.dispose();
};