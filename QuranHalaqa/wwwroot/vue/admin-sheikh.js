//TODO: Change me
var urlroot = "";

var appheikh = new Vue({
    el: "#app-sheikh",
    data: function () {
        return {
            fields: [
                { key: "SheikhFirstName", label: "First Name" },
                { key: "SheikhLastName", label: "Last Name" },
                { key: "SheikhEmail", label: "Email" },
                { key: "SheikhCellNumber", label: "Phone Number" },
                { key: "actions" }
            ],
            sheikhs: [],
            selectedSheikh: {
                SheikhFirstName: "",
                SheikhLastName: "",
                SheikhEmail: "",
                SheikhCellNumber: "",
                SheikhId: -1
            },
            modalDetails: { title: "", show: false },
            loading: false,
            error: null
        };
    },
    created() {
        // fetch the data when the view is created and the data is
        // already being observed
        this.fetchData();
    },
    methods: {
        fetchData() {
            this.error = this.post = null;
            this.loading = true;

            var url = urlroot + "/Admin/Sheikh/ListSheikh";
            axios.get(url).then(response => {
                if (response.status == 200) {
                    this.sheikhs = response.data;
                } else {
                    //TODO: Do something here.
                    throw "Could not retreive data.";
                }
            });
        },
        resetModal() {
            this.clear();
        },
        edit(data, index, btn) {
            this.modalDetails.title = "Edit Sheikh";
            this.$refs.formModal.show();
            this.selectedSheikh = data;

        },
        delete(data, index, btn) {
            console.log(data);
            console.log(index);
        },
        add() {
            this.clear();
            this.modalDetails.title = "Add Sheikh";
            this.$refs.formModal.show();
        },

        save() {
            var url = urlroot + "/Admin/Sheikh/Save";
            axios.post(url, this.selectedSheikh)
                .then(function (response) {
                    console.log(response);
                })
                .catch(function (error) {
                    console.log(error);
                });
            this.$refs.formModal.hide();
        },
        clear() {
            this.selectedSheikh = {
                SheikhFirstName: "",
                SheikhLastName: "",
                SheikhEmail: "",
                SheikhCellNumber: "",
                SheikhId: -1
            };
        },
        onSubmit(evt) {
            evt.preventDefault();
        },


    }
});
