<template>
  <div>
      <book-details  />
       
  </div>
</template>

<script>
import BookDetails from '@/components/BookDetails.vue'

export default {
    name: 'book-detail',
  components: { BookDetails },
  
  computed: {

    //   book() {
    //       return this.$store.state.books.find(
    //         b => b.isbn == this.$store.state.activeBook
    //       );
    //   }
  },
  created() {
        const activeBookIsbn = this.$route.params.isbn;
        this.$store.commit("SET_ACTIVE_BOOK", activeBookIsbn);
      }
}
</script>

<style>

</style>