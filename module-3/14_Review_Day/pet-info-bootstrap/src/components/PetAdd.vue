<template>
  <div class="container">
    <a href="#" class="btn btn-success" v-if="!isFormShown" v-on:click.prevent="isFormShown = true">Add Pet</a>
    <form v-if="isFormShown" v-on:submit.prevent="onSubmit">

      <div class="form-group">
        <label for="id">Id: </label>
        <input required type="number" class="form-control" v-model="newPet.id">
      </div>

      <div class="form-group">
        <label for="id">Type: </label>
        <input required type="text" class="form-control" v-model="newPet.type">
      </div>

      <div class="form-group">
        <label for="id">Name: </label>
        <input required type="text" class="form-control" v-model="newPet.name">
      </div>

      <div class="form-group">
        <label for="id">Breed: </label>
        <input required type="text" class="form-control" v-model="newPet.breed">
      </div>

      <div class="form-group">
        <label for="id">image: </label>
        <input type="url" class="form-control" v-model="newPet.image">
      </div>

      <input type="submit" value="Submit" class="btn btn-success"/>
      <input type="button" value="Cancel" class="btn btn-warning" v-on:click.prevent="resetForm"/>
    </form>
  </div>
</template>

<script>
export default {
  name: "PetAdd",
  data() {
    return {
      isFormShown: false,
      newPet: {},
    };
  },

  methods: {
    onSubmit() {
      this.$store.commit("ADD_PET", this.newPet)
      this.resetForm();
    },

    resetForm() {
      this.isFormShown = false;
      this.newPet = {};
    },
  },
};
</script>

<style>
form {
  width: 50%;
  margin: 20px;
}

label {
  text-align: left;
  display: block;
}

.btn {
  margin: 0 5px;
}
</style>