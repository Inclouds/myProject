singlePageApp.factory("courseRepository", function($http, $q) {
    return {
        get : function() {
            var deffered = $q.defer();
            $http.get("//")
        }
    }
});