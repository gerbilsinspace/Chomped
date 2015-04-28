var freelanceApp = angular.module('freelanceApp', [])

.controller('TabCtrl', function($scope) {
	$scope.tabs = [
		{
			'title': 'finance',
			'capitalized': 'Finance'
		},
		{
			'title': 'contacts',
			'capitalized': 'Contacts'
		},
		{
			'title': 'timesheet',
			'capitalized': 'Timesheet'
		},
		{
			'title': 'job manager', 
			'capitalized': 'Job Manager'
		}
	];
	$scope.tab = $scope.tabs[0].title;
	$scope.setTab = (function(title) {
		console.log(title);
		$scope.tab = title;
	})();
});