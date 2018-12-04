<template>
    <div id="user">
        <h1>Welcome to Hands on Vue.js with ASP.NET Core!</h1>
        <p>
            The time is: {{ time }}
        </p>
        <p>
            <ul>
                <li v-for="item in user" :key="item.userName">

                    UserFrom Bd {{ item.fullName }} - {{ item.userName }}

                </li>
            </ul>
        </p>
        
    </div>
</template>

<script>
   
    export default {
        name: 'user',
        data() {
            return {
                time: new Date().toString(),
                user: [],
                //products:[],
            }
        },
        mounted() {
            fetch('/api/user')
                .then(response => {
                    return response.json()
                })
                .then(data => {
                    this.user = data
                });
        }
}
</script>
