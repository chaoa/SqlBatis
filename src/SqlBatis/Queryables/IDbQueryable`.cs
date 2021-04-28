﻿using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Threading.Tasks;

namespace SqlBatis.Queryables
{
    /// <summary>
    /// 单表查询
    /// </summary>
    /// <typeparam name="T"></typeparam>
    public interface IDbQueryable<T>
    {
        /// <summary>
        /// count查询
        /// </summary>
        /// <param name="commandTimeout">超时时间</param>
        /// <returns></returns>
        int Count(int? commandTimeout = null);
        /// <summary>
        /// 异步count查询
        /// </summary>
        /// <param name="commandTimeout">超时时间</param>
        /// <returns></returns>
        Task<int> CountAsync(int? commandTimeout = null);
        /// <summary>
        /// count查询
        /// </summary>
        /// <typeparam name="TResult">类型推断</typeparam>
        /// <param name="expression">字段列表</param>
        /// <returns></returns>
        int Count<TResult>(Expression<Func<T, TResult>> expression);
        /// <summary>
        /// 异步count查询
        /// </summary>
        /// <typeparam name="TResult">类型推断</typeparam>
        /// <param name="expression">字段列表</param>
        /// <returns></returns>
        Task<int> CountAsync<TResult>(Expression<Func<T, TResult>> expression);
        /// <summary>
        /// delete查询
        /// </summary>
        /// <param name="commandTimeout"></param>
        /// <returns></returns>
        int Delete(int? commandTimeout = null);
        /// <summary>
        /// 异步delete查询
        /// </summary>
        /// <param name="commandTimeout"></param>
        /// <returns></returns>
        Task<int> DeleteAsync(int? commandTimeout = null);
        /// <summary>
        /// delete查询
        /// </summary>
        /// <param name="entity">查询条件</param>
        /// <returns></returns>
        int Delete(T entity);
        /// <summary>
        /// delete查询
        /// </summary>
        /// <param name="entities"></param>
        /// <returns></returns>
        int DeleteBatch(IEnumerable<T> entities);
        /// <summary>
        /// delete查询
        /// </summary>
        /// <param name="entities"></param>
        /// <returns></returns>
        Task<int> DeleteBatchAsync(IEnumerable<T> entities);
        /// <summary>
        /// delete查询
        /// </summary>
        /// <param name="entity">查询条件</param>
        /// <returns></returns>
        Task<int> DeleteAsync(T entity);
        /// <summary>
        /// delete查询
        /// </summary>
        /// <param name="expression">查询条件</param>
        /// <returns></returns>
        int Delete(Expression<Func<T, bool>> expression);
        /// <summary>
        /// 异步delete查询
        /// </summary>
        /// <param name="expression">查询条件</param>
        /// <returns></returns>
        Task<int> DeleteAsync(Expression<Func<T, bool>> expression);
        /// <summary>
        /// exists查询
        /// </summary>
        /// <param name="commandTimeout">超时时间</param>
        /// <returns></returns>
        bool Exists(int? commandTimeout = null);
        /// <summary>
        /// 异步exists查询
        /// </summary>
        /// <param name="commandTimeout">超时时间</param>
        /// <returns></returns>
        Task<bool> ExistsAsync(int? commandTimeout = null);
        /// <summary>
        /// exists查询
        /// </summary>
        /// <param name="expression">查询条件</param>
        /// <returns></returns>
        bool Exists(Expression<Func<T, bool>> expression);
        /// <summary>
        /// 异步exists查询
        /// </summary>
        /// <param name="expression">查询条件</param>
        /// <returns></returns>
        Task<bool> ExistsAsync(Expression<Func<T, bool>> expression);
        /// <summary>
        /// update查询，如果没有指定where则应用到所有记录
        /// </summary>
        /// <param name="commandTimeout">超时时间</param>
        /// <returns></returns>
        int Update(int? commandTimeout = null);
        /// <summary>
        /// 异步update查询，如果没有指定where则应用到所有记录
        /// </summary>
        /// <param name="commandTimeout">超时时间</param>
        /// <returns></returns>
        Task<int> UpdateAsync(int? commandTimeout = null);
        /// <summary>
        /// update查询，默认根据Primarkey更新，如果存在where则仅使用指定更新条件，
        /// 无法通过该接口更新主键字段和主键字段</summary>
        /// <typeparam name="Entity"></typeparam>
        /// <param name="entity"></param>
        /// <returns></returns>
        int Update<Entity>(Entity entity);
        /// <summary>
        /// 异步update查询，默认根据Primarkey更新，如果存在where则仅使用指定更新条件，
        /// 无法通过该接口更新主键字段和主键字段</summary>
        /// <typeparam name="Entity"></typeparam>
        /// <param name="entity"></param>
        /// <returns></returns>
        Task<int> UpdateAsync<Entity>(Entity entity);
        /// <summary>
        /// insert查询，该接口会忽略identity字段
        /// </summary>
        /// <typeparam name="Entity"></typeparam>
        /// <param name="entity"></param>
        /// <returns></returns>
        int Insert<Entity>(Entity entity);
        /// <summary>
        /// 异步insert查询，该接口会忽略identity字段
        /// </summary>
        /// <typeparam name="Entity"></typeparam>
        /// <param name="entity"></param>
        /// <returns></returns>
        Task<int> InsertAsync<Entity>(Entity entity);
        /// <summary>
        /// insert查询，并返回id，该接口会忽略identity字段
        /// </summary>
        /// <typeparam name="Entity"></typeparam>
        /// <param name="entity"></param>
        /// <returns></returns>
        int InsertReturnId<Entity>(Entity entity);
        /// <summary>
        /// 异步insert查询，并返回id，该接口会忽略identity字段
        /// </summary>
        /// <typeparam name="Entity"></typeparam>
        /// <param name="entity"></param>
        /// <returns></returns>
        Task<int> InsertReturnIdAsync<Entity>(Entity entity);
        /// <summary>
        /// 批量insert查询
        /// </summary>
        /// <typeparam name="Entity"></typeparam>
        /// <param name="entitys"></param>
        /// <returns></returns>
        int Insert<Entity>(IEnumerable<Entity> entitys);
        /// <summary>
        /// 异步批量insert查询，该接口会忽略identity字段
        /// </summary>
        /// <typeparam name="Entity"></typeparam>
        /// <param name="entitys"></param>
        /// <returns></returns>
        Task<int> InsertAsync<Entity>(IEnumerable<Entity> entitys);
        /// <summary>
        /// 批量新增
        /// </summary>
        /// <param name="entitys"></param>
        /// <param name="commandTimeout"></param>
        /// <returns></returns>
        int InsertBatch(IEnumerable<T> entitys, int? commandTimeout = null);
        /// <summary>
        /// 批量新增
        /// </summary>
        /// <param name="entitys"></param>
        /// <param name="commandTimeout"></param>
        /// <returns></returns>
        Task<int> InsertBatchAsync(IEnumerable<T> entitys, int? commandTimeout = null);
        /// <summary>
        /// select查询
        /// </summary>
        /// <param name="commandTimeout">超时时间</param>
        /// <returns></returns>
        IEnumerable<T> Select(int? commandTimeout = null);
        /// <summary>
        /// 异步select查询
        /// </summary>
        /// <param name="commandTimeout">超时时间</param>
        /// <returns></returns>
        Task<IEnumerable<T>> SelectAsync(int? commandTimeout = null);
        /// <summary>
        /// 分页select查询
        /// </summary>
        /// <param name="commandTimeout">超时时间</param>
        /// <returns>结果集，总记录数</returns>
        (IEnumerable<T>, int) SelectMany(int? commandTimeout = null);
        /// <summary>
        /// 异步分页select查询
        /// </summary>
        /// <param name="commandTimeout">超时时间</param>
        /// <returns></returns>
        Task<(IEnumerable<T>, int)> SelectManyAsync(int? commandTimeout = null);
        /// <summary>
        /// 指定查询字段
        /// </summary>
        /// <typeparam name="TResult">返回类型</typeparam>
        /// <param name="expression">字段列表</param>
        /// <param name="commandTimeout">超时时间</param>
        /// <returns></returns>
        IEnumerable<TResult> Select<TResult>(Expression<Func<T, TResult>> expression = null, int? commandTimeout = null);
        /// <summary>
        /// 异步select查询
        /// </summary>
        /// <typeparam name="TResult">返回类型</typeparam>
        /// <param name="expression">字段列表</param>
        /// <param name="commandTimeout">超时时间</param>
        /// <returns></returns>
        Task<IEnumerable<TResult>> SelectAsync<TResult>(Expression<Func<T, TResult>> expression = null, int? commandTimeout = null);
        /// <summary>
        /// 分页select查询
        /// </summary>
        /// <typeparam name="TResult">返回类型</typeparam>
        /// <param name="expression">字段列表</param>
        /// <param name="commandTimeout">超时时间</param>
        /// <returns></returns>
        (IEnumerable<TResult>, int) SelectMany<TResult>(Expression<Func<T, TResult>> expression = null, int? commandTimeout = null);
        /// <summary>
        /// 异步分页select查询
        /// </summary>
        /// <typeparam name="TResult">返回类型</typeparam>
        /// <param name="expression">字段列表</param>
        /// <param name="commandTimeout">超时时间</param>
        /// <returns></returns>
        Task<(IEnumerable<TResult>, int)> SelectManyAsync<TResult>(Expression<Func<T, TResult>> expression = null, int? commandTimeout = null);
        /// <summary>
        /// select查询
        /// </summary>
        /// <param name="commandTimeout">超时时间</param>
        /// <returns></returns>
        T Single(int? commandTimeout = null);
        /// <summary>
        /// 异步select查询
        /// </summary>
        /// <param name="commandTimeout">超时时间</param>
        /// <returns></returns>
        Task<T> SingleAsync(int? commandTimeout = null);
        /// <summary>
        /// select查询
        /// </summary>
        /// <typeparam name="TResult">返回类型</typeparam>
        /// <param name="expression">字段列表</param>
        /// <param name="commandTimeout">超时时间</param>
        /// <returns></returns>
        TResult Single<TResult>(Expression<Func<T, TResult>> expression = null, int? commandTimeout = null);
        /// <summary>
        /// 异步select查询
        /// </summary>
        /// <typeparam name="TResult">返回类型</typeparam>
        /// <param name="expression">字段列表</param>
        /// <param name="commandTimeout">超时时间</param>
        /// <returns></returns>
        Task<TResult> SingleAsync<TResult>(Expression<Func<T, TResult>> expression = null, int? commandTimeout = null);
        /// <summary>
        /// 忽略所有空列
        /// </summary>
        /// <param name="ignoreAllNullColumns"></param>
        /// <returns></returns>
        IDbQueryable<T> Ignore(bool ignoreAllNullColumns = true);
        /// <summary>
        /// 在insert,update,select时忽略字段
        /// </summary>
        /// <typeparam name="TResult"></typeparam>
        /// <param name="expression"></param>
        /// <param name="condition"></param>
        /// <returns></returns>
        IDbQueryable<T> Ignore<TResult>(Expression<Func<T, TResult>> expression, bool condition = true);
        /// <summary>
        /// set查询
        /// </summary>
        /// <typeparam name="TResult">类型推断</typeparam>
        /// <param name="column">字段</param>
        /// <param name="value">参数</param>
        /// <param name="condition">是否有效</param>
        /// <returns></returns>
        IDbQueryable<T> Set<TResult>(Expression<Func<T, TResult>> column, TResult value, bool condition = true);
        /// <summary>
        /// set查询
        /// </summary>
        /// <typeparam name="TResult">类型推断</typeparam>
        /// <param name="column">字段</param>
        /// <param name="expression">表达式</param>
        /// <param name="condition">是否有效</param>
        /// <returns></returns>
        IDbQueryable<T> Set<TResult>(Expression<Func<T, TResult>> column, Expression<Func<T, TResult>> expression, bool condition = true);
        /// <summary>
        /// take查询，从下标为0的行获取count条记录
        /// </summary>
        /// <param name="count">记录个数</param>
        /// <param name="condition">条件</param>
        /// <returns></returns>
        IDbQueryable<T> Take(int count, bool condition = true);
        /// <summary>
        /// skip，从下标为index的行获取count条记录
        /// </summary>
        /// <param name="index">起始下标</param>
        /// <param name="count">记录个数</param>
        /// <param name="condition">条件</param>
        /// <returns></returns>
        IDbQueryable<T> Skip(int index, int count, bool condition = true);
        /// <summary>
        /// page查询，从下标为(index-1)*count的行获取count条记录
        /// </summary>
        /// <param name="index">起始页码</param>
        /// <param name="count">记录个数</param>
        /// <param name="condition">条件</param>
        /// <returns></returns>
        IDbQueryable<T> Page(int index, int count, bool condition = true);
        /// <summary>
        /// 指定读锁
        /// </summary>
        /// <param name="lockname"></param>
        /// <returns></returns>
        IDbQueryable<T> With(string lockname);
        /// <summary>
        /// where查询，多个where有效使用and连接
        /// </summary>
        /// <param name="expression">表达式</param>
        /// <param name="condition">是否有效</param>
        /// <returns></returns>
        IDbQueryable<T> Where(Expression<Func<T, bool>> expression, bool condition = true);
        /// <summary>
        /// having查询，多个having查询有效使用and连接
        /// </summary>
        /// <param name="expression">表达式</param>
        /// <param name="condition">是否有效</param>
        /// <returns></returns>
        IDbQueryable<T> Having(Expression<Func<T, bool>> expression, bool condition = true);
        /// <summary>
        /// group查询
        /// </summary>
        /// <typeparam name="TResult">类型推断</typeparam>
        /// <param name="expression">字段列表</param>
        /// <returns></returns>
        IDbQueryable<T> GroupBy<TResult>(Expression<Func<T, TResult>> expression);
        /// <summary>
        /// orderby查询，升序
        /// </summary>
        /// <typeparam name="TResult">类型推断</typeparam>
        /// <param name="expression">字段列表</param>
        /// <param name="condition">是否有效</param>
        /// <returns></returns>
        IDbQueryable<T> OrderBy<TResult>(Expression<Func<T, TResult>> expression, bool condition = true);
        /// <summary>
        /// orderby查询，降序
        /// </summary>
        /// <typeparam name="TResult">类型推断</typeparam>
        /// <param name="expression">字段列表</param>
        /// <param name="condition">是否有效</param>
        /// <returns></returns>
        IDbQueryable<T> OrderByDescending<TResult>(Expression<Func<T, TResult>> expression, bool condition = true);
    }
}
